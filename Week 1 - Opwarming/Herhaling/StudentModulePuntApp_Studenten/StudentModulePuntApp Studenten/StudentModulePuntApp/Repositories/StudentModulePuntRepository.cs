﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StudentModulePuntApp.Repositories
{
    public class StudentModulePuntRepository
    {
        public async static Task<List<StudentModulePunt>> Entries()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(@"http://localhost:56608/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("StudentModulePunt");
                if (response.IsSuccessStatusCode)
                {
                    String s = await response.Content.ReadAsStringAsync();
                    List<StudentModulePunt> resultaat = JsonConvert.DeserializeObject<List<StudentModulePunt>>(s);
                    return resultaat;
                }
                else
                    return null;
            }
        }       
    }
}
