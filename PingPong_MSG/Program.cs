
using PingPong_MSG;

Class1 rmq = new Class1();
Console.WriteLine("Tekan tombol apapun untuk inisialisasi RMQ parameters.");
Console.ReadKey();
rmq.InitRMQConnection(); // inisialisasi parameter (secara default) untuk koneksi ke server RMQ
Console.WriteLine("Tekan tombol apapun untuk membuka koneksi ke RMQ.");
Console.ReadKey();
rmq.CreateRMQConnection(); // memulai koneksi dengan RMQ
Console.Write("Masukkan nama queue channel untuk mengirim pesan melalui RMQ.\n>> ");
string queue_name = Console.ReadLine();
rmq.CreateRMQChannel(queue_name);
while (true)
{
    rmq.WaitingMessage(queue_name);
}