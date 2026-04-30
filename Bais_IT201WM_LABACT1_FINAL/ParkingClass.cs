using Bais_IT201WM_LABACT1_FINAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bais_IT201WM_LABACT1_FINAL
{
    internal class ParkingClass
    {


        public string PlateNumber { get; set; }
        public string VehicleType { get; set; }
        public int HoursParked { get; set; }
        public string SlotNumber { get; set; }
        public double ParkingFee { get; private set; }

        private const double ServiceCharge = 20;

  
        public ParkingClass(string plate, string type, int hours, string slot)
        {
            PlateNumber = plate;
            VehicleType = type;
            HoursParked = hours;
            SlotNumber = slot;
            ParkingFee = ComputeFee();
        }

      
        private double ComputeFee()
        {
            double rate = 0;
            switch (VehicleType)
            {
                case "Car": rate = 50; break;
                case "Motorcycle": rate = 30; break;
                case "Van": rate = 70; break;
            }

            double total = (HoursParked * rate) + ServiceCharge;

  
            if (HoursParked > 8)
            {
                total += 100; 
            }

            return total;
        }


        public double ApplyDiscount(string discountType)
        {
            if (discountType == "Senior" || discountType == "Employee")
            {
                return ParkingFee * 0.8; 
            }
            return ParkingFee;
        }


        public string GenerateReceipt(string discountType = "")
        {
            double finalFee = string.IsNullOrEmpty(discountType) ? ParkingFee : ApplyDiscount(discountType);

            return $"Parking Receipt \n" +
                   $"Plate Number: {PlateNumber}\n" +
                   $"Vehicle Type: {VehicleType}\n" +
                   $"Hours Parked: {HoursParked}\n" +
                   $"Slot Number: {SlotNumber}\n" +
                   $"Base Fee: {ParkingFee:C}\n" +
                   (string.IsNullOrEmpty(discountType) ? "" : $"Discount Applied: {discountType}\n") +
                   $"Total Amount: {finalFee:C}\n";
        }
    }
}









    