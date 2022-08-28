namespace NC.Models.Tools
{
    public class TarazParameters
    {

        public string DorehId { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }

        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string PreCondation { get; set; } = "1=1";

    }

}
