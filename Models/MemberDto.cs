public class MemberDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string TelegramHandle { get; set; }
    public string TwitterHandle { get; set; }
    public string WalletAddress { get; set; }
    public int Role { get; set; }

    public string RoleText
    {
        get
        {
            switch (Role)
            {
                case 1: return "TeamLeader";
                case 2: return "President";
                case 3: return "VicePresident";
                default: return "Member";
            }
        }
        set
        {
            switch (value)
            {
                case "TeamLeader": Role = 1; break;
                case "President": Role = 2; break;
                case "VicePresident": Role = 3; break;
                default: Role = 0; break;
            }
        }
    }
}
