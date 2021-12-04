using System;

public class BTLAB4_4
{
    static public void Main()
    {
        Console.WriteLine("SO THICH CA NHAN \n");
        Console.WriteLine("============================");
        Console.WriteLine("1.DOC SACH");
        Console.WriteLine("2. NGHE NHAC ");
        Console.WriteLine("3.CHOI THE THAO");
        Console.WriteLine("4.MAY TINH");
        Console.WriteLine("5.Thoat"); 
        Console.WriteLine("CHON : ");
        int n = Convert.ToInt32(Console.ReadLine());
        switch(n)
        {
            case 1: 
                Console.WriteLine("BAN THICH DOC SACH ");
                break;
            case 2:
                Console.WriteLine("BAN THICH NGHE NHAC");
                break ;
            case 3:
                Console.WriteLine("BAN THICH CHOI THE THAO");
                break;
            case 4:
                Console.WriteLine("BAN THICH MAY TINH");
                break;
            case 5:
                Console.WriteLine("HEN GAP LAI");
                break;
            default:
                Console.WriteLine("BAN VUI LONG NHAP LAI ");
                break;
        }       


        

    }
}


