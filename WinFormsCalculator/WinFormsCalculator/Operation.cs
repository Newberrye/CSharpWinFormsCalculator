namespace WinFormsCalculator;

/// <summary>
/// Holds information about a single calculator operation
/// </summary>
public class Operation
{
    #region Public Properties
    /// <summary>
    /// The left side of the operation.
    /// </summary>
    public string LeftSide { get; set; }
    /// <summary>
    /// The right side of the operation.
    /// </summary>
    public string RightSide { get; set; }
    /// <summary>
    /// Type of operation to perform.
    /// </summary>
    public OperationType OperationType { get; set; }
    /// <summary>
    /// Inner operation to performed before operation.
    /// </summary>
    public Operation InnerOperation { get; set; }
    #endregion

    /// <summary>
    /// Default constructor
    /// </summary>
    public Operation()
    {
        // Makes strings empty.
        this.LeftSide = string.Empty;
        this.RightSide = string.Empty;
    }
}
