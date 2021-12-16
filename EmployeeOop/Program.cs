using System;

namespace EmployeeOop
{
    class Program
    {

        static void Main(string[] args)
        {
            //ProgramActivityImp akses = new ProgramActivityImp();
            OptionMenu();
        }
        static void OptionMenu()
        {
            Access akses = new Access();
            bool repeat = false;
            do
            {
                Console.WriteLine("1.Tambah Karyawan");
                Console.WriteLine("2.Hapus Karyawan ke?");
                Console.WriteLine("3.Lihat Daftar Karyawan");
                Console.WriteLine("4.Hapus Semua Data Karyawan");
                Console.WriteLine("5.Keluar");
                try
                {
                    Console.Write("Masukkan pilihan menu (1-4): ");
                    int menu = int.Parse(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            int amount = InputChoice();
                            int loop= 0;
                            while(loop<amount)
                            {
                                Employee e = new Employee(amount,akses);
                                akses.AddEmployee(e);
                                loop++;
                            }
                            repeat = true;
                            break;
                        case 2:
                            akses.DeleteChoice();
                            repeat = true;
                            break;
                        case 3:
                            akses.PrintEmployee();
                            repeat = true;
                            break;
                        case 4:
                            akses.DeleteEmployee();
                            repeat = true;
                            break;
                        case 5:
                            repeat = false;
                            break;
                        default:
                            Console.WriteLine("Menu tidak ditemukan");
                            repeat = true;
                            break;
                    }
                    Console.WriteLine("Press any key to back....");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.WriteLine("Inputan harus angka");
                    Console.WriteLine("Press any key to back....");
                    Console.ReadKey();
                    Console.Clear();
                    repeat = true;
                }
            } while (repeat == true);
        }
        public static int InputChoice()
        {
            int amount = 0;
            bool repeat = false;
            do
            {
                try
                {
                    Console.Write("Masukkan Jumlah Karyawan: ");
                    amount = int.Parse(Console.ReadLine());
                    repeat = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    repeat = true;
                }
            } while (repeat == true);
            return amount;
        }

    }
}
