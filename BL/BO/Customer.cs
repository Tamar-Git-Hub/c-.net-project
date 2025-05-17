namespace BO;

public class Customer
{
    public int Identity { get; init; }
    public string Name { get; set; }
    public string? Address { get; set; }
    public string Phone { get; set; }
    public override string ToString() => this.ToStringProperty();
    public Customer(int id, string name, string? address, string phon)
    {
        this.Identity = id;
        this.Name = name;
        this.Address = address;
        this.Phone = phon;
    }

}
