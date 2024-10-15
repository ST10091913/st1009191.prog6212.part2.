using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class ReviewClaimsWindow : Window
    {
        public ReviewClaimsWindow()
        {
            InitializeComponent();
            LoadClaims();
        }

        private void LoadClaims()
        {
            // Assuming ClaimStorage is a static class holding claims
            ClaimsListView.ItemsSource = ClaimStorage.GetClaims(); // Load claims from storage
        }

        private void Approve_Click(object sender, RoutedEventArgs e)
        {
            // Logic to approve selected claim
            var selectedClaim = ClaimsListView.SelectedItem as Claim;
            if (selectedClaim != null)
            {
                selectedClaim.Status = "Approved";
                MessageBox.Show($"Claim approved for {selectedClaim.LecturerName}");
                LoadClaims(); // Refresh the list
            }
        }

        private void Reject_Click(object sender, RoutedEventArgs e)
        {
            //  reject selected claim
            var selectedClaim = ClaimsListView.SelectedItem as Claim;
            if (selectedClaim != null)
            {
                selectedClaim.Status = "Rejected";
                MessageBox.Show($"Claim rejected for {selectedClaim.LecturerName}");
                LoadClaims(); // Refresh the list
            }
        }
    }
}
