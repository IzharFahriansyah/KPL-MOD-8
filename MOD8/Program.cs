using System;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static MOD8.Config;


namespace MOD8
{

    class Program
    {
        static void Main(string[] args)
        {
            int trf, pilih;
            BankTransferConfig Conf = new BankTransferConfig();
            Console.WriteLine("Language / Bahasa :");
            Conf.configuration.lang = Console.ReadLine();
            if (Conf.configuration.lang == "en")
            {
                Console.WriteLine("Please insert the amount of money to transfer: ");
                trf = Convert.ToInt32(Console.ReadLine());


                if (trf < Conf.configuration.transfer.threshold)
                {
                    Console.WriteLine("Transfer Fee = " + Conf.configuration.transfer.low_fee);
                    Console.WriteLine("Total Amount = " + (trf + Conf.configuration.transfer.low_fee));
                    Console.WriteLine("Select Transfer Method : ");
                    for (int i = 0; i < Conf.configuration.methods.Count; i++)
                    {
                        Console.WriteLine((i + 1) + " " + Conf.configuration.methods[i]);
                    }

                    pilih = Convert.ToInt32(Console.ReadLine());
                    if (pilih == 1)
                    {
                        Console.WriteLine("Please type 'yes' to confirm the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmations.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("Transfer is cancelled");
                            Console.Read();
                        }
                    }
                    else if (pilih == 2)
                    {
                        Console.WriteLine("Please type 'yes' to confirm the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmations.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("Transfer is cancelled");
                            Console.Read();
                        }
                    }
                    else if (pilih == 3)
                    {
                        Console.WriteLine("Please type 'yes' to confirm the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmations.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("Transfer is cancelled");
                            Console.Read();
                        }
                    }
                    else if (pilih == 4)
                    {
                        Console.WriteLine("Please type 'yes' to confirm the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmations.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("Transfer is cancelled");
                            Console.Read();
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Transfer Fee = " + Conf.configuration.transfer.high_fee);
                    Console.WriteLine("Total Amount = " + (trf + Conf.configuration.transfer.high_fee));
                    Console.WriteLine("Select Transfer Method : ");
                    for (int i = 0; i < Conf.configuration.methods.Count; i++)
                    {
                        Console.WriteLine((i + 1) + " " + Conf.configuration.methods[i]);
                    }
                    pilih = Convert.ToInt32(Console.ReadLine());
                    if (pilih == 1)
                    {
                        Console.WriteLine("Please type 'yes' to confirm the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmations.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("Transfer is cancelled");
                            Console.Read();
                        }
                    }
                    else if (pilih == 2)
                    {
                        Console.WriteLine("Please type 'yes' to confirm the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmations.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("Transfer is cancelled");
                            Console.Read();
                        }
                    }
                    else if (pilih == 3)
                    {
                        Console.WriteLine("Please type 'yes' to confirm the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmations.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("Transfer is cancelled");
                            Console.Read();
                        }
                    }
                    else if (pilih == 4)
                    {
                        Console.WriteLine("Please type 'yes' to confirm the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmations.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("Transfer is cancelled");
                            Console.Read();
                        }
                    }
                }

            }
            else if (Conf.configuration.lang == "id")
            {
                Console.WriteLine("Masukkan jumlah uang yang akan di-transfer: ");
                trf = Convert.ToInt32(Console.ReadLine());
                if (trf <= Conf.configuration.transfer.threshold)
                {
                    Console.WriteLine("Biaya Transfer = " + Conf.configuration.transfer.low_fee);
                    Console.WriteLine("Total Biaya = " + (trf + Conf.configuration.transfer.low_fee));
                    Console.WriteLine("Pilih Metode Transfer : ");
                    Console.WriteLine("Ketik 'ya' untuk mengkonfirmasi transaksi : ");
                    string crf = Console.ReadLine();
                    if (crf == Conf.configuration.confirmations.id)
                    {
                        Console.WriteLine("Proses Transfer Berhasil");
                    }
                    else
                    {
                        Console.WriteLine("Transfer dibatalkan");
                    }
                }
                else
                {
                    Console.WriteLine("Biaya Transfer = " + Conf.configuration.transfer.high_fee);
                    Console.WriteLine("Total Biaya = " + (trf + Conf.configuration.transfer.high_fee));
                    Console.WriteLine("Pilih Metode Transfer : ");
                    for (int i = 0; i < Conf.configuration.methods.Count; i++)
                    {
                        Console.WriteLine((i + 1) + " " + Conf.configuration.methods[i]);
                    }
                    pilih = Convert.ToInt32(Console.ReadLine());
                    if (pilih == 1)
                    {
                        Console.WriteLine("Ketik 'ya' untuk mengkonfirmasi transaksi : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmations.id)
                        {
                            Console.WriteLine("Proses Transfer Berhasil");
                        }
                        else
                        {
                            Console.WriteLine("Transfer dibatalkan");
                        }
                    }
                    else if (pilih == 2)
                    {
                        Console.WriteLine("Ketik 'ya' untuk mengkonfirmasi transaksi : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmations.id)
                        {
                            Console.WriteLine("Proses Transfer Berhasil");
                        }
                        else
                        {
                            Console.WriteLine("Transfer dibatalkan");
                        }
                    }
                    else if (pilih == 3)
                    {
                        Console.WriteLine("Ketik 'ya' untuk mengkonfirmasi transaksi : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmations.id)
                        {
                            Console.WriteLine("Proses Transfer Berhasil");
                        }
                        else
                        {
                            Console.WriteLine("Transfer dibatalkan");
                        }
                    }
                    else if (pilih == 4)
                    {
                        Console.WriteLine("Ketik 'ya' untuk mengkonfirmasi transaksi : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmations.id)
                        {
                            Console.WriteLine("Proses Transfer Berhasil");
                        }
                        else
                        {
                            Console.WriteLine("Transfer dibatalkan");
                        }
                    }

                }
            }

        }
    }
    public class Config
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public List<string> methods { get; set; }
        public Confirmations confirmations { get; set; }

        public Config()
        {

        }
        public Config(string bhs, Transfer trf, List<string> mtd, Confirmations cfr)
        {
            lang = bhs;
            transfer = trf;
            methods = mtd;
            confirmations = cfr;
        }
        public class Transfer
        {
            public int threshold { get; set; }
            public int low_fee { get; set; }
            public int high_fee { get; set; }
            public Transfer(int threshold, int low_fee, int high_fee)
            {
                this.threshold = threshold;
                this.low_fee = low_fee;
                this.high_fee = high_fee;
            }
        }
        public class Methods
        {
            public string metode { get; set; }
        }
        public class Confirmations
        {
            public string en { get; set; }
            public string id { get; set; }

            public Confirmations(string en, string id)
            {
                this.en = en;
                this.id = id;

            }
        }
    }
    public class BankTransferConfig
    {
        public Config configuration;
        public const string filePath = "D:\\Praktikum KPL\\MOD8\\MOD8\\bin\\Debug\\net8.0\\BankTransferConfig.json";

        public BankTransferConfig()
        {
            try
            {
                ReadConfigFile();
            }
            catch (Exception)
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }

        private void SetDefault()
        {

            List<string> met = new List<string>();
            met.Add("RTO(real - time)");
            met.Add("SKN");
            met.Add("RTGS");
            met.Add("BI FAST");
            configuration = new Config("en", new Config.Transfer(25000000, 6500, 15000), met, new Config.Confirmations("yes", "ya"));
        }

        private void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            String jsonString = System.Text.Json.JsonSerializer.Serialize(configuration, options);
            File.WriteAllText(filePath, jsonString);
        }

        private Config ReadConfigFile()
        {
            String configJsonData = File.ReadAllText(filePath);
            configuration = System.Text.Json.JsonSerializer.Deserialize<Config>(configJsonData);
            return configuration;
        }
    }

}

