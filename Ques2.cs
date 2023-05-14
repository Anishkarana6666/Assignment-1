public bool validate_datet(string date, string date_format)

     {
               try
               {
                 DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
                         
                 dtfi.LongDatePattern = date_format;

                DateTime dt = DateTime.ParseExactdate,date_format,dtfi);
               }
               catch(Exception)
               {
                    
                return false;
     
               }
          return true;
                    }