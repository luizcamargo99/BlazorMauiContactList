using System.ComponentModel;

namespace ContactList.Enums
{
    public enum EContactPriorization
    {
        [Description("Sem Prioridade")]
        None = 0,
        [Description("VIP")]
        VIP = 1,
        [Description("Família")]
        Family = 2,
        [Description("Amigo")]
        Friend = 3,
        [Description("Trabalho")]
        Work = 4,
        [Description("Irritante")]
        Annoying = 5
    }
}
