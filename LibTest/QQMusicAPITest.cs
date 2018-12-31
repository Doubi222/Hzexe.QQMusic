using Hzexe.QQMusic;
using System;
using Xunit;

namespace LibTest
{
    public class QQMusicAPITest
    {
        [Fact]
        public async void SearchAsyncTest()
        {
            var api = new QQMusicAPI();
            var arg = new SearchArg() { Keywords = "bye bye bye" };
            arg.PageSize = 30;
            var result = await api.SearchAsync(arg); //������������ȡ���
            Assert.NotNull(result);
            Assert.NotNull(result.song);
            Assert.NotEmpty(result.song.list);
        }

    }
}
