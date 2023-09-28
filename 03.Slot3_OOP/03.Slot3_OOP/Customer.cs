
class Customer
{
    private int id;
    /*public int CustomerID
    {
        get { return id; }
        set { id = value; }
    }*/

    public int CustomerID { get; set; }

    public String CustomerName { get; set; } = "Khoa";

    public String ToString()
    {
        return $"ID: {CustomerID}; Name: {CustomerName}";
    }
}
