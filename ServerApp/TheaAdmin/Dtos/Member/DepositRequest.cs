﻿namespace MySalon.Dtos;

public class DepositRequest
{
    public string MemberId { get; set; }
    public double Amount { get; set; }
    public double Bonus { get; set; }
    public string Description { get; set; }
}
