namespace ContractMonthlyClaimSystem
{
    public class Claim
    {
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public string AdditionalNotes { get; set; }
        public string UploadedFileName { get; set; }
        public string Status { get; set; } // e.g., "Pending", "Approved", "Rejected"
        public string LecturerName { get; set; } // Added lecturer name

        public Claim(double hoursWorked, double hourlyRate, string additionalNotes, string uploadedFileName, string lecturerName)
        {
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
            AdditionalNotes = additionalNotes;
            UploadedFileName = uploadedFileName;
            Status = "Pending"; // Default status
            LecturerName = lecturerName; // Initialize lecturer name
        }
    }
}
