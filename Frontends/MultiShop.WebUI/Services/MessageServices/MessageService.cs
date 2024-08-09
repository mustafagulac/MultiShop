﻿using MultiShop.DtoLayer.MessageDtos;

namespace MultiShop.WebUI.Services.MessageServices
{
    public class MessageService : IMessageService
    {
        private readonly HttpClient _httpClient;

        public MessageService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ResultInboxMessageDto>> GetInboxMessageAsync(string id)
        {
            var responseMessage = await _httpClient.GetAsync("http://localhost:5000/services/message/usermessages/GetMessageInbox?id=" + id);
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultInboxMessageDto>>();
            return values;
        }

        public async Task<List<ResultSendboxMessageDto>> GetSendboxMessageAsync(string id)
        {
            var responseMessage = await _httpClient.GetAsync("http://localhost:5000/services/message/usermessages/GetMessageSendbox?id=" + id);
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultSendboxMessageDto>>();
            return values;
        }
    }
}
