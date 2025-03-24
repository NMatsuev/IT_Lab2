using System.Text;
using IT_Lab2.utils;

namespace IT_Lab2
{
    public partial class FrmMain : Form
    {
        private const int BUFFER_MAX_SIZE = 400000;
        private const int BYTES_AMOUNT = 30;
        private const int BYTE_SIZE = 8;
        private const int REGISTER_SIZE = 25;

        private Queue<bool> _register;
        private bool[] _input;
        private bool[] _key;
        public string StartKey { get { return GetStartKey(); } }
        public string Key { get { return GetKey(); } set { SetKey(value); } }
        public string Input { get { return GetInput(); } set { SetInput(value); } }
        public string Output { get { return GetOutput(); } set { SetOutput(value); } }

        private string GetStartKey()
        {
            return Cleaner.ToBinary(TxtBoxPrimKey.Text);
        }

        private string GetKey()
        {
            return RichTxtBoxKey.Text;
        }

        private void SetKey(string key)
        {
            RichTxtBoxKey.Text = key;
        }

        private string GetInput()
        {
            return Cleaner.ToBinary(RichTxtBoxInitText.Text);
        }

        private void SetInput(string input)
        {
            RichTxtBoxInitText.Text = input;
        }

        private string GetOutput()
        {
            return RichTxtBoxResultText.Text;
        }

        private void SetOutput(string output)
        {
            RichTxtBoxResultText.Text = output;
        }


        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (Input == "" || StartKey == "")
            {
                MessageBox.Show("В полях для ввода исходного текста и начального состояния регистра должна быть хотя бы одна цифра 0 или 1.");
                return;
            }

            if (StartKey.Length < REGISTER_SIZE)
            {
                MessageBox.Show("В поле для ввода начального состояния регистра должно быть не менее 25 двоичных цифр.");
                return;
            }
            Cursor = Cursors.WaitCursor;
            _input = Converter.BoolArrayFromString(Input);
            _register = Converter.BoolQueueFromString(StartKey, REGISTER_SIZE);
            _key = KeyMaker.Create(_register, Input.Length);
            Update(Converter.StringFromBoolArray(_key), Converter.StringFromBoolArray(ArraysOperations.Xor(_input, _key)));
            Cursor = Cursors.Default;
        }
        private void Update(string key, string output)
        {
            Key = key;
            Output = output;
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                Update("", "");
                try
                {
                    using (FileStream fileStream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        byte[] buffer;
                        if (fileStream.Length > BUFFER_MAX_SIZE)
                        {
                            buffer = new byte[2*BYTES_AMOUNT];
                            fileStream.Read(buffer, 0, BYTES_AMOUNT);
                            fileStream.Seek(-BYTES_AMOUNT, SeekOrigin.End);
                            fileStream.Read(buffer, BYTES_AMOUNT, BYTES_AMOUNT);
                            MessageBox.Show($"Выведены первые и последние {BYTES_AMOUNT} байт.");
                        }
                        else
                        {
                            buffer = new byte[fileStream.Length];
                            fileStream.Read(buffer, 0, buffer.Length);
                        }
                        Input = Converter.StringFromByteArray(buffer);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }

        }

        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fileStream = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                    {
                        byte[] buffer;
                        byte addBits = (byte) ((BYTE_SIZE - Output.Length % BYTE_SIZE) % BYTE_SIZE);
                        if (addBits != 0)
                        {
                            buffer = Converter.ByteArrayFromString(Output+string.Concat(Enumerable.Repeat('0', addBits)));
                            fileStream.Write(buffer, 0, buffer.Length);
                            MessageBox.Show($"Файл сохранен с дополнением {addBits} нулей в конце для получения целого числа байтов.");
                        }
                        else
                        {
                            buffer = Converter.ByteArrayFromString(Output);
                            fileStream.Write(buffer, 0, buffer.Length);
                            MessageBox.Show("Файл сохранен успешно.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void TxtBoxPrimKey_TextChanged(object sender, EventArgs e)
        {
            LabelDigitsCount.Text = StartKey.Length.ToString();
        }
    }
}