class Product
{

public Guid Id { get; set; }

public string  Brand { get; set; }

public Guid ColorId { get; set; }

public Guid SizeId { get; set; }

public double Price { get; set; }

public string Description { get; set; }

public double Stocl { get; set; }

public bool IsActive { get; set; }

public DateTime CreateAt { get; set; }

}