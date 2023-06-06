DateTime d1 = DateTime.Now.ToString("dd-MM-yyyy");
DateTime d2 = DateTime.Now.AddDays(2);
TimeSpan t = d1 - d2;
double diff = t.TotalDays;