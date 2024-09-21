namespace RTProSLDevTools.Models;

public class SpParameter
{
    public int ObjectId { get; set; }
    public string? Name { get; set; }
    public int ParameterId { get; set; }
    public byte SystemTypeId { get; set; }
    public int UserTypeId { get; set; }
    public short MaxLength { get; set; }
    public byte? Precision { get; set; }
    public byte? Scale { get; set; }
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
}


