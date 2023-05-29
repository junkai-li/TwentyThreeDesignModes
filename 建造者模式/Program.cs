namespace 建造者模式
{
    public class Product
    {
        private String ground;
        private String cement;
        private String roof;

        public Product()
        {
        }

        public String getGround()
        {
            return ground;
        }

        public void setGround(String ground)
        {
            this.ground = ground;
        }

        public String getCement()
        {
            return cement;
        }

        public void setCement(String cement)
        {
            this.cement = cement;
        }

        public String getRoof()
        {
            return roof;
        }

        public void setRoof(String roof)
        {
            this.roof = roof;
        }
    }
    public interface Builder
    {

        // 一般来说，有多少零配件，就有多少建造方法
        void buildGround();
        void buildCement();
        void buildRoof();

        // 返回产品类
        Product buildProduct();

    }
    public class ConcreteBuilder : Builder
    {

        private Product product = new Product();

        public void buildGround()
        {
            Console.WriteLine("build地基");
            product.setGround("build地基");
        }

        public void buildCement()
        {
            Console.WriteLine("build水泥");
            product.setGround("build水泥");
        }

        public void buildRoof()
        {
            Console.WriteLine("build楼顶");
            product.setGround("build楼顶");
        }
        public Product buildProduct()
        {
            Console.WriteLine("建造完毕!");
            return product;
        }
    }

    public class Director
    {
        private Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public Product construct()
        {
            // 构建顺序：建造水泥->地基->楼顶
            builder.buildCement();
            builder.buildGround();
            builder.buildRoof();

            return builder.buildProduct();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.construct();

        }
    }
}