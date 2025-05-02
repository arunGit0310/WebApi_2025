namespace WebApi_2025.Model
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime DOB {  get; set; }
        public int GenderId {  get; set; }
        public string GenderName { get; set; }=string.Empty;
        public int BranchId {  get; set; }
        public string BranchName { get; set; } = string.Empty;
    }
}
