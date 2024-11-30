CREATE DATABASE puskesmas;
USE puskesmas;

CREATE TABLE signUp(
userr VARCHAR(10),
pass VARCHAR(10)
);

CREATE OR REPLACE TABLE dokter (
    id_dokter VARCHAR(3) PRIMARY KEY,
    nama VARCHAR(100) NOT NULL,
    spesialisasi VARCHAR(100),
    nomor_telepon VARCHAR(15),
    alamat TEXT,
    jadwal_praktik VARCHAR(100) 
);

CREATE OR REPLACE TABLE pasien (
    id_pasien VARCHAR(3) PRIMARY KEY,
    nama VARCHAR(100) NOT NULL,
    tanggal_lahir DATE,
    jenis_kelamin VARCHAR(10),
    alamat TEXT,
    nomor_telepon VARCHAR(15),
    riwayat_penyakit TEXT
);


CREATE OR REPLACE TABLE apotek(
    kd_obat VARCHAR(3) PRIMARY KEY,
    jenis_obat VARCHAR(100) NOT NULL,
    nama_obat VARCHAR(15),
    stock INT 
);

CREATE OR REPLACE TABLE kunjungan (
    id_kunjungan VARCHAR(3) PRIMARY KEY,
    id_pasien VARCHAR(3),
    id_dokter VARCHAR(3),
    tanggal_kunjungan DATE,
    keluhan TEXT,
    diagnosa TEXT,
    CONSTRAINT fk1 FOREIGN KEY (id_pasien) REFERENCES pasien(id_pasien),
    CONSTRAINT fk2 FOREIGN KEY (id_dokter) REFERENCES dokter(id_dokter)
);

CREATE OR REPLACE TABLE DokterGaji (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nama VARCHAR(100),
    jenis_dokter VARCHAR(50),
    gaji_bulanan BIGINT,
    tunjangan INT,
    pajak BIGINT
);

CREATE TABLE history_kunjungan (
    id_kunjungan INT PRIMARY KEY,
    id_pasien VARCHAR(3),
    id_dokter VARCHAR(3),
    tanggal_kunjungan DATE,
    keluhan TEXT,
    diagnosa TEXT,
    tanggal_hapus TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);


INSERT INTO dokter VALUES 
    ('D01', 'Dr. Aisyah Rahma', 'Dokter Umum', '081234567890', 'Jl. Sehat No.1, Jakarta', 'Senin-Kamis 08:00-12:00'),
    ('D02', 'Dr. Budi Santoso', 'Dokter Gigi', '082345678901', 'Jl. Merdeka No.5, Bandung', 'Selasa-Jumat 09:00-13:00'),
    ('D03', 'Dr. Chandra Wijaya', 'Kesehatan Ibu dan Anak', '083456789012', 'Jl. Kemerdekaan No.10, Surabaya', 'Rabu-Sabtu 10:00-14:00'),
    ('D04', 'Dr. Dian Anggraini', 'Gizi', '084567890123', 'Jl. Kebon Jeruk No.15, Medan', 'Senin-Jumat 07:00-11:00'),
    ('D05', 'Dr. Eko Pratama', 'Penyakit Dalam', '085678901234', 'Jl. Mangga Dua No.20, Yogyakarta', 'Kamis-Minggu 08:00-12:00');


INSERT INTO pasien (id_pasien, nama, tanggal_lahir, jenis_kelamin, alamat, nomor_telepon, riwayat_penyakit)
VALUES
    ('P01', 'Ahmad Fauzi', '1990-05-15', 'Laki-laki', 'Jl. Sehat No.12, Jakarta', '081234567890', 'Hipertensi'),
    ('P02', 'Siti Aisyah', '1985-09-25', 'Perempuan', 'Jl. Merdeka No.8, Bandung', '082345678901', 'Diabetes'),
    ('P03', 'Budi Santoso', '2002-03-30', 'Laki-laki', 'Jl. Kemerdekaan No.20, Surabaya', '083456789012', 'Asma'),
    ('P04', 'Dewi Ratna', '1995-07-18', 'Perempuan', 'Jl. Kebon Jeruk No.17, Medan', '084567890123', 'Alergi Makanan'),
    ('P05', 'Eko Prasetyo', '1978-12-05', 'Laki-laki', 'Jl. Mangga Dua No.25, Yogyakarta', '085678901234', 'Kolesterol Tinggi');


INSERT INTO apotek (kd_obat, jenis_obat, nama_obat, stock) 
VALUES 
    ('O01', 'Analgesik', 'Paracetamol', 100),
    ('O02', 'Antibiotik', 'Amoxicillin', 50),
    ('O03', 'Antasida', 'Promag', 75),
    ('O04', 'Antihistamin', 'Loratadine', 30),
    ('O05', 'Vitamin', 'Vitamin C', 200),
    ('O06', 'Antiseptik', 'Betadine', 40),
    ('O07', 'Antipiretik', 'Ibuprofen', 60),
    ('O08', 'Kortikosteroid', 'Dexamethasone', 20),
    ('O09', 'Antiemetik', 'Ondansetron', 35),
    ('O10', 'Ekspektoran', 'Ambroxol', 80);


INSERT INTO kunjungan (id_kunjungan, id_pasien, id_dokter, tanggal_kunjungan, keluhan, diagnosa) 
VALUES
('K01', 'P01', 'D01', '2024-11-01', 'Sakit kepala dan pusing', 'Migraine'),
('K02', 'P02', 'D02', '2024-11-05', 'Batuk dan demam', 'Flu'),
('K03', 'P03', 'D03', '2024-11-10', 'Nyeri dada dan sesak nafas', 'Angina'),
('K04', 'P04', 'D04', '2024-11-12', 'Nyeri perut dan mual', 'Gastritis'),
('K05', 'P05', 'D05', '2024-11-15', 'Pusing dan lemas', 'Anemia');
   

INSERT INTO DokterGaji (nama, jenis_dokter, gaji_bulanan, tunjangan, pajak)
VALUES
('Dr. Andi', 'Spesialis Jantung', 15000000, 2000000, 3000000),
('Dr. Budi', 'Spesialis Anak', 13000000, 1800000, 2500000),
('Dr. Chika', 'Dokter Umum', 10000000, 1500000, 2000000),
('Dr. Dian', 'Spesialis Kulit', 12000000, 1700000, 2400000),
('Dr. Eko', 'Spesialis Mata', 14000000, 1900000, 2700000);

INSERT INTO signUp VALUES
('admin', 'sin123.');

DELIMITER $$

CREATE TRIGGER before_delete_kunjungan
BEFORE DELETE ON kunjungan
FOR EACH ROW
BEGIN
    INSERT INTO history_kunjungan (id_kunjungan, id_pasien, id_dokter, tanggal_kunjungan, keluhan, diagnosa)
    VALUES (OLD.id_kunjungan, OLD.id_pasien, OLD.id_dokter, OLD.tanggal_kunjungan, OLD.keluhan, OLD.diagnosa);
END$$

DELIMITER ;

#DROP DATABASE puskesmas