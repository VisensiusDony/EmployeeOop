using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeOop
{
    class Employee
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Npp { get; set; }
        public int Overtime { get; set; }//dalam jam
        public int Allowance { get; set; }
        public int Salary { get; set; }
        public int TotalSalary { get; set; }
        public string Status { get; set; }

        public Employee(int amount,Access access)
        {
            bool repeat = false;
            int choice;
            int overtimeMoney;
            bool outerLoop = true;
            Console.Write("\nMasukkan nama karyawan: ");
            this.Name = Console.ReadLine();
            var employeeName = access.name.Exists(x => x == Name);
            access.name.Add(Name);
            while (outerLoop == true)
            {
                if (employeeName == true)
                {
                    Name = null;
                    Console.WriteLine("Karyawan Sudah Ada");
                    outerLoop = false;
                }
                else
                {
                    Console.Write("Masukkan kota karyawan: ");
                    this.City = Console.ReadLine();
                    Console.Write("Masukkan NPP karyawan: ");
                    this.Npp = Console.ReadLine();
                    do
                    {
                        try
                        {
                            Console.Write("Masukkan jam lembur karyawan: ");
                            this.Overtime = int.Parse(Console.ReadLine());
                            repeat = false;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            repeat = true;
                        }
                    } while (repeat == true);
                    do
                    {
                        try
                        {
                            Console.Write("Masukkan golongan karyawan (1-3): ");
                            choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    this.Salary = 2000000;
                                    this.Allowance = 200000;
                                    this.Status = "Pegawai Golongan I";
                                    break;
                                case 2:
                                    this.Salary = 3000000;
                                    this.Allowance = 250000;
                                    this.Status = "Pegawai Golongan II";
                                    break;
                                case 3:
                                    this.Salary = 4000000;
                                    this.Allowance = 300000;
                                    this.Status = "Pegawai Golongan III";
                                    break;
                                default:
                                    Console.WriteLine("Golongan tidak ditemukan");
                                    break;
                            }
                            if (Overtime > 0 && choice == 1)
                            {
                                overtimeMoney = 15000;
                                repeat = false;
                            }
                            else if (Overtime > 0 && choice == 2)
                            {
                                overtimeMoney = 20000;
                                repeat = false;
                            }
                            else if (Overtime > 0 && choice == 3)
                            {
                                overtimeMoney = 25000;
                                repeat = false;
                            }
                            else
                            {
                                overtimeMoney = 0;
                                repeat = true;
                            }
                            this.TotalSalary = CountSalary(Salary, Overtime, Allowance, overtimeMoney);

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            repeat = true;
                        }

                    } while (repeat == true);
                }
                outerLoop = false;
            }
            
        }
        public static int CountSalary(int salary, int overtime, int allowance, int overtimeMoney)
        {
            int totalSalary;
            totalSalary = salary + allowance + (overtime * overtimeMoney);
            return totalSalary;
        }
    }
}
