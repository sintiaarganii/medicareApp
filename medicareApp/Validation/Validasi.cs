using System.Windows.Forms;

namespace medicareApp.Validation
{
    internal class Validasi
    {
        public bool valId(string id)
        {
            if (string.IsNullOrEmpty(id) || id.Length != 3 || !char.IsUpper(id[0]) || !char.IsDigit(id[1]) || !char.IsDigit(id[2]))
            {
                MessageBox.Show("Input id Failed, id must be exactly 3 characters: the first character must be an uppercase letter and the last two characters must be digits.", "add id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public bool valName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Nama tidak boleh kosong", "add name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!char.IsUpper(name[0]))
            {
                MessageBox.Show("Huruf pertama harus kapital", "add name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            for (int a = 0; a < name.Length; a++)
            {
                if (char.IsDigit(name[a]) || !char.IsLetter(name[a]))
                {
                    MessageBox.Show("Input Name failed, The first letter must be capitalized, there must be no numbers or symbols", "add name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public bool valUser(string user)
        {
            if (string.IsNullOrWhiteSpace(user) || user.Length < 5)
            {
                MessageBox.Show("Username harus memiliki panjang minimal 5 karakter", "add user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            for (int a = 0; a < user.Length; a++)
            {
                if (char.IsDigit(user[a]) || !char.IsLower(user[a]))
                {
                    MessageBox.Show("Input user failed, must be lowercase letters only, no numbers or symbols", "add user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public bool valPass(string pass)
        {
            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Password tidak boleh kosong", "Validasi Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (pass.Length < 8)
            {
                MessageBox.Show("Password harus minimal 8 karakter", "Validasi Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool hasLetter = false; 
            bool hasDigit = false;  
            bool hasSymbol = false;

            foreach (char ch in pass)
            {
                if (char.IsLetter(ch)) hasLetter = true;      
                else if (char.IsDigit(ch)) hasDigit = true;   
                else if (!char.IsLetterOrDigit(ch)) hasSymbol = true; 
            }

            if (!hasLetter)
            {
                MessageBox.Show("Password harus mengandung minimal satu huruf", "Validasi Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!hasDigit)
            {
                MessageBox.Show("Password harus mengandung minimal satu angka", "Validasi Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!hasSymbol)
            {
                MessageBox.Show("Password harus mengandung minimal satu simbol", "Validasi Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool valAlamat(string alamat)
        {
            if (string.IsNullOrWhiteSpace(alamat))
            {
                MessageBox.Show("Alamat tidak boleh kosong", "Validasi Alamat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!char.IsUpper(alamat[0]))
            {
                MessageBox.Show("Huruf pertama pada alamat harus kapital", "Validasi Alamat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            for (int i = 0; i < alamat.Length; i++)
            {
                char currentChar = alamat[i];

                if (!(char.IsLetterOrDigit(currentChar) || currentChar == ' ' || currentChar == '.'))
                {
                    MessageBox.Show("Alamat hanya boleh mengandung huruf, angka, spasi, dan titik", "Validasi Alamat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true; 
        }

        public bool valTlp(string noTlp)
        {
            if (string.IsNullOrWhiteSpace(noTlp))
            {
                MessageBox.Show("Nomor telepon tidak boleh kosong", "Validasi Nomor Telepon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (noTlp.Length < 12 || noTlp.Length > 13)
            {
                MessageBox.Show("Nomor telepon harus terdiri dari 12 atau 13 angka", "Validasi Nomor Telepon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (noTlp[0] != '0')
            {
                MessageBox.Show("Nomor telepon harus dimulai dengan angka '0'", "Validasi Nomor Telepon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (noTlp[1] != '8')
            {
                MessageBox.Show("Karakter kedua nomor telepon harus '8'", "Validasi Nomor Telepon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if ("35798".IndexOf(noTlp[2]) == -1)
            {
                MessageBox.Show("Karakter ketiga nomor telepon hanya boleh '3', '5', '7', '9', atau '8'", "Validasi Nomor Telepon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            for (int i = 3; i < noTlp.Length; i++)
            {
                if (!char.IsDigit(noTlp[i]))
                {
                    MessageBox.Show("Nomor telepon hanya boleh berisi angka", "Validasi Nomor Telepon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true; 
        }

        public bool valSps(string val)
        {
            if (string.IsNullOrWhiteSpace(val))
            {
                MessageBox.Show("Input Spesialis tidak boleh kosong", "Validasi Spesialis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!char.IsUpper(val[0]))
            {
                MessageBox.Show("Huruf pertama harus kapital", "Validasi Spesialis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (char c in val)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Input Spesialis tidak boleh mengandung angka atau simbol", "Validasi Spesialis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true; 
        }

        public bool valkeluhan(string val)
        {
            if (string.IsNullOrWhiteSpace(val))
            {
                MessageBox.Show("Input Keluhan tidak boleh kosong", "Validasi Keluhan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!char.IsUpper(val[0]))
            {
                MessageBox.Show("Huruf pertama harus kapital", "Validasi Keluhan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (char c in val)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Input Keluhan tidak boleh mengandung angka atau simbol", "Validasi Keluhan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true; 
        }

        public bool valDiagnosa(string val)
        {
            if (string.IsNullOrWhiteSpace(val))
            {
                MessageBox.Show("Input Diagnosa tidak boleh kosong", "Validasi Diagnosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!char.IsUpper(val[0]))
            {
                MessageBox.Show("Huruf pertama harus kapital", "Validasi Diagnosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (char c in val)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Input Diagnosa tidak boleh mengandung angka atau simbol", "Validasi Diagnosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true; 
        }

        public bool valRiwayat(string val)
        {
            if (string.IsNullOrWhiteSpace(val))
            {
                MessageBox.Show("Input Riwayat Penyakit tidak boleh kosong", "Validasi Riwayat Penyakit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!char.IsUpper(val[0]))
            {
                MessageBox.Show("Huruf pertama harus kapital", "Validasi Riwayat Penyakit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (char c in val)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Input Riwayat Penyakit tidak boleh mengandung angka atau simbol", "Validasi Riwayat Penyakit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        public bool valStok(string val)
        {
            foreach (char c in val)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Inputan Stok hanya boleh angka", "Validasi Stok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

    }
}