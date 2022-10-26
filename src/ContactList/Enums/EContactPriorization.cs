using System.ComponentModel;

namespace ContactList.Enums
{
    public enum EContactPriorization
    {
        [Description("No Priority")]
        None = 0,
        [Description("VIP")]
        VIP = 1,
        [Description("Family")]
        Family = 2,
        [Description("Friend")]
        Friend = 3,
        [Description("Coworker")]
        Work = 4,
        [Description("Annoying")]
        Annoying = 5
    }
}
