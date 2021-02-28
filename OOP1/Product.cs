using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet--prop yazıldıgında çıkan kare ve altındaki nokta noktalara verilen ad: tab tab basılırsa otomatik olarak özellikler oluşturur 
    class Product  //entity--varlık
    {    //bu tür classlarda sadece ve sadece özellik olur
        public int Id { get; set; }   //Id--bir nesneyi diğerinden ayırt edebilmek için kullanılan alan. Genellikle veri tabanlarında kullanılır (tc kimlik no gibi bir şey)
        public int CategoryId { get; set; } //categoryId -- hangi kategoriye ait bir ürün oldugu yazılır
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //CRUD--create-read-update-delete
        //otomasyon projelerinde genellikle veri tabanı programla yapılır.bankacılık,e ticaret,youtube,kodlama.io vb


    }
}
