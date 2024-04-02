# oop-interface-csharp

## Sub Capaian Pembelajaran

1. Mahasiswa mampu menggunakan interface
2. Mahasiswa mampu menggunakan abstract class dan interface pada situasi yang berbeda

## Lingkungan Pengembangan

1. Platform: .NET 6.0
2. Bahasa: C# 10
3. IDE: Visual Studio 2022

## Cara membuka project menggunakan Visual Studio

1. Clone repositori project `oop-interface-csharp` ke direktori lokal git Anda.
2. Buka Visual Studio, pilih menu File > Open > Project/Solution > Pilih file *.sln.
3. Tekan tombol Open untuk  untuk membuka solusi.
4. Baca soal dengan seksama. Buat implementasi kode sesuai dengan petunjuk.
6. Jalankan unit test di project *.Tests

> PERINGATAN: Push kode program ke remote repository jika hanya seluruh test case sudah lolos/passed (bertanda hijau).

## Soal-soal

### Soal: Kebun Binatang

Buat solusi dari soal ini di project `Solution` folder `Zoo` dengan namespace `Solution.Zoo`.

Sebuah kebun binatang memiliki berbagai jenis hewan. Beberapa hewan di kebun binatang tersebut dapat melakukan aksi khusus, seperti mengeluarkan suara.

Buatlah sebuah interface bernama `IBersuara` yang memiliki informasi sebagai berikut:
- Metode publik `Suara` yang mengembalikan suara dari hewan tersebut (tipe string).

Buatlah kelas abstrak `Hewan` dengan variabel instance `_nama` (tipe String) dan properti getter `Nama` untuk mengembalikan nama hewan.

Dari kelas `Hewan`, turunkan tiga kelas yaitu `Singa`, `Kuda`, dan `Ular`. 
- Kelas `Singa` mengimplementasi interface `IBersuara` dan ketika memanggil metode `Suara` akan mengembalikan "Roar".
- Kelas `Kuda` mengimplementasi interface `IBersuara` dan ketika memanggil metode `Suara` akan mengembalikan "Neigh".
- Kelas `Ular` tidak mengimplementasi interface `IBersuara` karena ular tidak mengeluarkan suara yang khas.

Buatlah sebuah kelas bernama `KebunBinatang` yang memiliki informasi sebagai variabel instance berupa daftar hewan (tipe List<Hewan>). Kelas `KebunBinatang` harus memiliki metode untuk menambahkan hewan ke dalam daftar dengan nama `TambahHewan`, dan metode `DengarkanHewanBersuara` yang menampilkan hanya hewan-hewan yang bisa bersuara dengan format.

- Singa bernama Simba bersuara Roar
- Kuda bernama Woody bersuara Neigh

Buatlah sebuah kelas bernama `Program` yang didalamnya terdapat metode static `Main`. Instansiasi objek dari kelas `KebunBinatang`, tambahkan beberapa hewan ke dalam daftar, dan tampilkan hewan-hewan yang bisa bersuara ke layar dengan memanggil metode `DengarkanHewanBersuara`.

### Soal: Toko Barang

Buat solusi dari soal ini di project `Solution` folder `Shops` dengan namespace `Solution.Shops`.

Sebuah toko menjual berbagai jenis barang, termasuk barang elektronik dan mobil listrik. Beberapa barang memerlukan sumber listrik untuk dapat berfungsi.

Buatlah sebuah interface bernama `IElectrifiable` yang memiliki informasi sebagai berikut:
- Metode `PowerOn` yang digunakan untuk menyalakan perangkat.
- Metode `PowerOff` yang digunakan untuk mematikan perangkat.

Buatlah kelas publik abstrak `Barang` dengan variabel instance `_merk` (tipe string) dan properti getter `Merk` untuk mengembalikan merk barang.

Dari kelas `Barang`, turunkan tiga kelas yaitu `Televisi`, `KipasAngin`, dan `MobilListrik`. 
- Kelas `Televisi` mengimplementasi interface `IElectrifiable` dan ketika memanggil metode `PowerOn` akan mengembalikan "Televisi dinyalakan", dan `PowerOff` akan mengembalikan "Televisi dimatikan".
- Kelas `KipasAngin` mengimplementasi interface `IElectrifiable` dan ketika memanggil metode `PowerOn` akan mengembalikan "Kipas Angin dinyalakan", dan `PowerOff` akan mengembalikan "Kipas Angin dimatikan".
- Kelas `MobilListrik` mengimplementasi interface `IElectrifiable` dan ketika memanggil metode `PowerOn` akan mengembalikan "Mobil Listrik siap berjalan", dan `PowerOff` akan mengembalikan "Mobil Listrik berhenti".

Buatlah sebuah kelas bernama `ElectricityProvider` yang memiliki metode static `SupplyPower` yang menerima parameter objek yang mengimplementasi interface `IElectrifiable` dan menyalakan perangkat tersebut.

Buatlah sebuah kelas bernama `Program` yang didalamnya terdapat metode static `Main`. Instansiasi objek dari kelas `Televisi`, `KipasAngin`, dan `MobilListrik`, kemudian gunakan `ElectricityProvider` untuk menyuplai listrik ke perangkat tersebut dan tampilkan ke layar.

### Soal: Urutan Barang

Buat solusi dari soal ini di project `Solution` folder `ObjectSorter` dengan namespace `Solution.ObjectSorter`.

Sebuah aplikasi digunakan untuk mengurutkan berbagai jenis barang berdasarkan kriteria tertentu. Beberapa barang dapat diurutkan, tetapi tidak semuanya.

Buatlah sebuah interface bernama `ISortable` yang memiliki informasi sebagai berikut:
- Metode `Compare` yang mengembalikan nilai (tipe int). Jika objek yang dicompare lebih kecil urutannya maka return -1, jika sama urutannya return 0, jika lebih besar maka return 1.

Buatlah kelas abstrak `Item` dengan variabel instance `_nama` (tipe string) dan properti getter `Nama` untuk mengembalikan nama item.

Dari kelas `Item`, turunkan tiga kelas yaitu `Buku`, `Sepatu`, dan `Makanan`. 
- Kelas `Buku` memiliki variabel instance tambahan yaitu `_jumlahHalaman` (tipe int). Kelas `Buku` mengimplementasi interface `ISortable` dan metode `Compare` akan membandingkan berdasarkan `_jumlahHalaman`.
- Kelas `Sepatu` memiliki variabel instance tambahan yaitu `_ukuran` (tipe int). Kelas `Sepatu` mengimplementasi interface `ISortable` dan metode `Compare` akan membandingkan berdasarkan `_ukuran`.
- Kelas `Makanan` hanya memiliki variabel instance `_nama` dan tidak mengimplementasi interface `ISortable`.

Buatlah sebuah kelas bernama `Sorter` yang memiliki metode static `SortItems` yang menerima parameter berupa array dari objek yang mengimplementasi interface `ISortable` dan mengembalikan array yang sudah diurutkan berdasarkan metode `Compare`.

Buatlah sebuah kelas bernama `Program` yang didalamnya terdapat metode static `Main`. Instansiasi objek dari kelas `Buku` dan `Sepatu`, kemudian gunakan `Sorter` untuk mengurutkan item-item tersebut dan tampilkan hasil pengurutan ke layar.

### Soal: Toko Buku Online

Buat solusi dari soal ini di project `Solution` folder `Bookstore` dengan namespace `Solution.Bookstore`.

Anda diminta untuk membuat sistem sederhana untuk toko buku online yang menangani penjualan buku. Beberapa buku memiliki fitur tambahan seperti akses ke versi digital.

Buatlah sebuah interface bernama `IDigitalAccessible` yang memiliki informasi sebagai berikut:
- Metode `AccessDigitalCopy` yang digunakan untuk mengakses salinan digital buku.

Buatlah kelas publik abstrak `Buku` dengan variabel instance `_judul` (tipe string), `_penulis` (tipe string), dan properti getter untuk kedua variabel tersebut.

Dari kelas `Buku`, turunkan dua kelas yaitu `BukuFisik` dan `BukuDigital`. 
- Kelas `BukuFisik` tidak mengimplementasi interface apapun dan memiliki metode `PrintInfo` yang ketika dipanggil akan mengembalikan "Buku fisik: [_judul] oleh [_penulis]".
- Kelas `BukuDigital` mengimplementasi interface `IDigitalAccessible` dan selain metode `PrintInfo` yang mengembalikan "Buku digital: [_judul] oleh [_penulis]", ketika memanggil metode `AccessDigitalCopy` akan mengembalikan "Mengakses salinan digital buku [_judul]".

Buatlah sebuah kelas bernama `DigitalLibrary` yang memiliki metode static `ProvideAccess` yang menerima parameter objek yang mengimplementasi interface `IDigitalAccessible` dan mengakses salinan digital buku tersebut.

Buatlah sebuah kelas bernama `Program` yang didalamnya terdapat metode static `Main`. Instansiasi objek dari kelas `BukuFisik` dan `BukuDigital`, kemudian gunakan `DigitalLibrary` untuk menyediakan akses ke salinan digital untuk buku digital dan tampilkan pesan ke layar.

### Extra

> Saatnya Kreatif!

Buat soal Anda sendiri dan solusinya di project `Solution` folder `Extra` dengan namespace `Solution.Extra` di file `Extra.cs`.

Buat spesifikasi soal Anda sendiri yang memuat hal-hal sebagai berikut:

- Nama kelas dan interface yang dibuat. Jelaskan masing-masing kegunaannya.
- Atribut dan properti apa saja yang harus ada di kelas.
- Metode apa saja yang dibutuhkan.
- Validasi atau aturan apa yang harus dilakukan.
- Penggunaan interface sebagai tipe data.

Kemudian, implementasikan solusi kelas dari soal Anda di file `Extra.cs` dan eksekusi implementasinya di `Program.cs`.

=== Selesai ===


