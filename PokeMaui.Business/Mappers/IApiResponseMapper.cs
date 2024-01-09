namespace PokeMaui.Business.Mappers
{
    public interface IApiResponseMapper<TDto , TApiResponse>
    {
        public TDto MapFromApiResponseObject(TApiResponse response);
    }
}
