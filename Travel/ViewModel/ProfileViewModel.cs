using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Travel.Model;
using Travel.Services;

namespace Travel.ViewModel
{
    public class ProfileViewModel: Bindable
    {
        private bool inProgress;
        public bool InProgress
        {
            get => inProgress;
            set => SetField<bool>(ref inProgress, value);
        }

        private Data profile;
        public Data Profile
        {
            get => profile;
            set => SetField<Data>(ref profile, value);
        }

        public ProfileViewModel()
        {
            this.profile = new Data();
            this.inProgress = false;
        }

        public async Task RequestDataUsingRestService()
        {
            List<Data> result = await RestService<Data>.GetAsyncRequest(Config.exampleProfileApiRequest);
            List<Data> users = result.FindAll((obj) => obj.First_name.ToLower().Contains("g"));

            if (users.Count > 0) this.Profile = users[0];
        }
    }
}
