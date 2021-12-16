using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeOop
{
    abstract class ActivityImp : IActivity
    {
        public List<Employee> employee = new List<Employee>();
        public List<string> name = new List<string>();
        Office office = new Office();

        public virtual void PrintEmployee()
        {
            Console.WriteLine("======================================================================");
            PrintOffice();
            Console.WriteLine("Daftar Gaji Total Karyawan");
            Console.Write("|Nama|\t");
            Console.Write("|Alamat|\t");
            Console.Write("|NPP|\t");
            Console.Write("|Jam Lembur|\t");
            Console.Write("|Tunjangan|\t");
            Console.Write("|Gaji|\t\t");
            Console.Write("|Status|\t\t");
            Console.WriteLine("|Gaji Total|");
            foreach (var element in employee){
                Console.Write($"|{element.Name}|");
                Console.Write($"\t| { element.City}  |");
                Console.Write($"\t\t| { element.Npp } |");
                Console.Write($"\t| { element.Overtime}  |");
                Console.Write($"\t\t|  {element.Allowance}  |");
                Console.Write($"\t|  {element.Salary}  |");
                Console.Write($"\t| { element.Status}  |");
                Console.WriteLine($"\t\t| { element.TotalSalary} |");
            }
            Console.WriteLine("======================================================================");
        }
        public virtual void PrintOffice()
        {
           office.OfficeName = "PT Maju Mundur";
           office.OfficeAddress = "Surabaya";
           Console.WriteLine($"Nama Kantor\t:{ office.OfficeName} ");
           Console.WriteLine($"Alamat Kantor\t:{ office.OfficeAddress} ");
        }

        
        public virtual void AddEmployee(Employee employee)
        {
            if (employee.Name != null) {
                this.employee.Add(employee);
                Console.WriteLine("==============================");
                Console.WriteLine("Sukses Menambahkan");
                Console.WriteLine("==============================");
                PrintEmployee();
            }
            else
            {
                Console.ReadKey();
            }
            
        }

        public void DeleteChoice()
        {
            bool repeat = false;
            do
            {
                try
                {
                    if (employee.Count > 0)
                    {
                        Console.Write("Hapus Transaksi ke-");
                        int hapus = int.Parse(Console.ReadLine());
                        employee.RemoveAt(hapus - 1);
                        Console.WriteLine("Data sukses terhapus!");
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Data tidak ada!");
                        repeat = false;
                    }
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Inputan Salah!");
                    repeat = true;
                }
            } while (repeat == true);
            Console.ReadLine();
        }
        public void DeleteEmployee()
        {
            employee.Clear();
        }
        
    }
}
