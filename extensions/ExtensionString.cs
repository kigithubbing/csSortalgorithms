namespace extensions;

public class ExtensionString{
	private string _value {get; set; }
	public ExtensionString(string value) => _value = value;

  public static bool operator > (ExtensionString a, ExtensionString b) =>
	string.Compare(a._value, b._value) > 0;
  public static bool operator < (ExtensionString a, ExtensionString b) =>
	string.Compare(a._value,b._value) < 0;
}
