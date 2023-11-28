
# Booking Hotel

Ini adalah sebuah project Aplikasi Desktop untuk memenuhi persyaratan UAS (Ujian Akhir Semester). Aplikasi ini berfungsi sebagai management User, Staff, Room dan Reservation. Sesuai dengan namanya, aplikasi ini juga bisa melakukan booking.


## Features

- Login
- Register
- Management User
- Management Staff
- Management Category
- Management Room
- Management Reservation
- Multi User

## Instalasi

Instal dengan git clone

```bash
git clone https://github.com/Delendins/hotel-v2.git

cd hotel-v2
```

Setelah berhasil di clone, didalamnya terdapat folder database. Restore database tersebut dengan SQL Management Studio

## Instalasi Database

Klik "Connect"

[![image.png](https://i.postimg.cc/mDKd9FDX/image.png)](https://postimg.cc/KkrrSjtB)

Klik "Restore Database..."

[![image.png](https://i.postimg.cc/wBmFpjFD/image.png)](https://postimg.cc/7CqS1DFL)

Pilih "Device" dan Klik "..."

[![image.png](https://i.postimg.cc/908y96JW/image.png)](https://postimg.cc/YLF4Ky5V)

Klik "Add"

[![image.png](https://i.postimg.cc/SKFCc77z/image.png)](https://postimg.cc/7595kzRx)

Arahkan ke folder database, pilih databasenya dan Klik "OK"

[![image.png](https://i.postimg.cc/rF7rLCHY/image.png)](https://postimg.cc/tYtT3Pph)

Klik "OK"

[![image.png](https://i.postimg.cc/Dwg4bkZR/image.png)](https://postimg.cc/SnnxwPcG)

Klik "OK"

[![image.png](https://i.postimg.cc/W4xNdXMQ/image.png)](https://postimg.cc/B8c9y57g)

Klik "OK"

[![image.png](https://i.postimg.cc/cJtZGwVT/image.png)](https://postimg.cc/p9v3DhVn)

## Configurasi File "connect.cs"

Buka "hotel-v2.sln"

Buka file "connect.cs"

[![image.png](https://i.postimg.cc/wxDqBCwz/image.png)](https://postimg.cc/dDtPHxMN)

Rubah "Datasource" menjadi nama device/server kalian

```c#
public SqlConnection GetConn()
{
    SqlConnection conn = new SqlConnection("Data Source=YOURE-SERVER\\SQLEXPRESS;Initial Catalog=hotel-v2;Integrated Security=True");
    return conn;
}
```

[![image.png](https://i.postimg.cc/J0r2MHTG/image.png)](https://postimg.cc/hzYr0vRB)

Selesai
    
## Authors

- [@Delendins](https://www.github.com/Delendins)

