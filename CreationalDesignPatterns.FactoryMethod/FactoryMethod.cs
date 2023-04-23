namespace CreationalDesignPatterns.FactoryMethod;

public abstract class WebSite
{
    public abstract void CreatePages();
}

public class WebSiteEcommerce : WebSite
{
    public override void CreatePages()
    {
        //E-ticaret sayfası için özelleştirilmiş kodlar
    }
}

public class WebSiteBlog : WebSite
{
    public override void CreatePages()
    {
        //Blog sayfası için özelleştilmiş kodlar
    }
}

public abstract class WebSiteFactory
{
    public abstract WebSite CreateWebSite();
}

public class WebSiteFactoryEcommerce : WebSiteFactory
{
    public override WebSite CreateWebSite()
    {
        return new WebSiteEcommerce();
    }
}

public class WebSiteFactoryBlog : WebSiteFactory
{
    public override WebSite CreateWebSite()
    {
        return new WebSiteBlog();
    }
}