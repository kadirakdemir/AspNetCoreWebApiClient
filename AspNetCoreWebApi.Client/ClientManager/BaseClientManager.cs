using AspNetCoreWebApi.Client.ClientManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AspNetCoreWebApi.Client.ClientManager
{
    public class BaseClientManager<TEntity> : IBaseClientManager<TEntity> where TEntity : class
    {

        private static string _baseUrl;
        static HttpClient _client;
        static string _url;

        public void Url(string baseUrl, string url)
        {
            _url = url;
            _baseUrl = baseUrl;
        }

        public void Client()
        {
            _client.BaseAddress = new Uri(_baseUrl);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public ICollection<TEntity> GetAll()
        {
            try
            {
                using (_client = new HttpClient())
                {
                    Client();
                    var response = _client.GetAsync($"{_url}").Result;
                    response.EnsureSuccessStatusCode();
                    return response.Content.ReadAsAsync<ICollection<TEntity>>().Result;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ICollection<TEntity>> GetAllAsync()
        {
            try
            {
                using (_client = new HttpClient())
                {
                    Client();
                    var response = _client.GetAsync($"{_url}").Result;
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsAsync<ICollection<TEntity>>();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            try
            {
                using (_client = new HttpClient())
                {
                    Client();
                    var response = _client.GetAsync($"{_url}/{id}").Result;
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsAsync<TEntity>();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TEntity GetById(int id)
        {
            try
            {
                using (_client = new HttpClient())
                {
                    Client();
                    var response = _client.GetAsync($"{_url}/{id}").Result;
                    response.EnsureSuccessStatusCode();
                    return response.Content.ReadAsAsync<TEntity>().Result;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Add(TEntity entity)
        {
            try
            {
                using (_client = new HttpClient())
                {
                    Client();
                    var response = _client.PostAsJsonAsync($"{ _url}", entity).Result;
                    //response.Wait();
                    //var result = response.Result;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(int id, TEntity entity)
        {using (_client = new HttpClient())
                {
                    Client();
                    var response = _client.PutAsJsonAsync($"{_url}/{id}", entity).Result;
                }
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (_client = new HttpClient())
                {
                    Client();
                    var response = _client.DeleteAsync($"{_url}/{id}").Result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
