namespace HotelProject.WebUI.Models.Role
{
    public class RoleAssignViewModel
    {
        public string? RoleName { get; set; }
        public int RoleID { get; set; }
        public bool RoleExist { get; set; } //O role sahip mi, evet ise true değil ise false dönecek.
    }
}
