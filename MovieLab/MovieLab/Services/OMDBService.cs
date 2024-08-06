using MovieLab.Models;

namespace MovieLab.Services;

public class OMDBService : IOMDBService
{

    //make a method that calss the api
    //and returns the C# ojects from the json
    public async Task<OMDBResponse> SearchMovies(string movieName)
    {
        //create the url as a string with all the info in it 
        string url = $"http://www.omdbapi.com/?apikey=16efb775&s={movieName}";

        //call the api and get a response
        using (HttpClient client = new HttpClient())
        {
            try
            {
                OMDBResponse response = await client.GetFromJsonAsync<OMDBResponse>(url);//using Get Verb that's built in, go get the url, take the json you get back and turn it into this C# object
                //Make the api call to this url,heres your verb get....GetFromJsonAsync, result back will be C#, something we can use
                //Convert JavaScript to C#
                return response;
            }
            catch (Exception ex) //if database is down, api down, bad code = doesnt work, network dropped for a few sec and request was lost
            {
                Console.WriteLine(ex.Message);//Log the exception that happened
                return null;//Did not get anything, simple ways of handling it, other ways to approach it...
            }
        }

        //if the response is goodm return the movies

        //if the response is not good write a log


    }




}

