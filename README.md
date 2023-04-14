
# CountriesExcelGenerator

Gets countries information from a free API endpoint, filters the data and writes it on a Excel (.xls) file.




## API Used

#### Get all countries

```http
  GET https://restcountries.com/v3.1/all
```


## What the script does:

- HTTP Request to get the country information -> .nuget package used: RestSharp
- Filters the response from the request
- Data filtered is written in a Excel (.xls) file -> .nuget package used: IronXL.Excel

(Please keep in mind that it can't be run in Release mode, only in Debug mode. The IronXL.Excel dependency is not free when is used in Release mode and it needs a licence)
## Authors

- [@soniapop93](https://github.com/soniapop93)


## 🚀 About Me
This is a personal project that I worked on in my free time to improve my skills in C#. As someone who is passionate about programming, I'm always looking for opportunities to learn and refine my abilities, and this project was a perfect opportunity to do just that.

Throughout this project, I challenged myself to take on new programming concepts and techniques, building on my existing knowledge and perfecting my skills in C#. By working on this project in my spare time, I was able to take my learning to the next level and gain valuable experience that will aid me in my future programming pursuits.

Overall, this project represents my dedication to mastering C# and my commitment to continual learning and growth as a programmer.


