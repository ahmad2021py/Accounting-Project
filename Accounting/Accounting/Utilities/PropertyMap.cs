
namespace Accounting.Utilities
{
    public class PropertyMap
    {
        /*   Example
            
            
            
        List<PropertyMap> prlist = new List<PropertyMap> {

                new PropertyMap()
                {
                    PropertyName ="Company" ,
                    PropertyValue= cbCompany.Text,


                } ,
                new PropertyMap()
                {

                    PropertyName = "Picture" ,
                    PropertyValue= WorkWithImage.imageToByteArray(PboxProductPicture.Image)
                  }


                };




        */




        public string PropertyName { get; set; }
        public object PropertyValue { get; set; }

    }


}

