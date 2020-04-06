namespace ScriptMigration.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public bool ShowRequestId { get{return string.IsNullOrWhiteSpace(this.RequestId) == false;  } }
    }
}