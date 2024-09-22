namespace RTProSLDevTools.Dtos
{
    public class SpParametersDto
    {
        public int ObjectId { get; set; }
        public string? Name { get; set; }
        public byte SystemTypeId { get; set; }
        public string? TypeName { get; set; }
        public short MaxLength { get; set; }
        public int? Precision { get; set; }
        public int ParameterId { get; set; }
        public int UserTypeId { get; set; }
        public int? Scale { get; set; }
        public bool IsOutput { get; set; }
        public bool IsCursorRef { get; set; }
        public bool HasDefaultValue { get; set; }
        public bool IsXmlDocument { get; set; }
        public object? DefaultValue { get; set; }
        public int XmlCollectionId { get; set; }
        public bool IsReadonly { get; set; }
        public bool? IsNullable { get; set; }
        public int? EncryptionType { get; set; }
        public string? EncryptionTypeDesc { get; set; }
        public string? EncryptionAlgorithmName { get; set; }
        public int? ColumnEncryptionKeyId { get; set; }
        public string? ColumnEncryptionKeyDatabaseName { get; set; }
        public string? Collation { get; set; }
    }
}
