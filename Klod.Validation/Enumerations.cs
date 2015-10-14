namespace Klod.Validation
{
	/// <summary>
	/// Enumeration for all supported comparison operators.
	/// </summary>
	public enum ConstraintOperator:byte
	{
		Equal
		,GreaterThanOrEqual
		,LessThanOrEqual
		,NotEqual
		,GreaterThan
		,LessThan
		,Range		//valid between value1 and value2 (inclusive)	
		,OptionsSet	//one of them is valid: value1|value2|value3
	}
}