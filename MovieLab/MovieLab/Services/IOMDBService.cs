using MovieLab.Models;

namespace MovieLab.Services;

public interface IOMDBService//Interfaces are like a contract implement the interface you sign on to do certain things and you got them
{
    Task<OMDBResponse> SearchMovies(string movieName);
}
