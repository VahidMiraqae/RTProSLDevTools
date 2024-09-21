namespace RTProSLDevTools.Dtos
{
    public class GetSpParametersDto
    {
        public int ObjectId { get; set; }
        public string? Name { get; set; }
        public byte SystemTypeId { get; set; }
        public short MaxLength { get; set; }
        public int? Precision { get; set; }
    }
}
