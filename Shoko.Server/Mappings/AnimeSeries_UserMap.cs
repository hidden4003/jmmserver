﻿using FluentNHibernate.Mapping;
using Shoko.Models.Server;
using Shoko.Server.Entities;

namespace Shoko.Server.Mappings
{
    public class AnimeSeries_UserMap : ClassMap<SVR_AnimeSeries_User>
    {
        public AnimeSeries_UserMap()
        {
            Table("AnimeSeries_User");

            Not.LazyLoad();
            Id(x => x.AnimeSeries_UserID);
            Map(x => x.JMMUserID).Not.Nullable();
            Map(x => x.AnimeSeriesID).Not.Nullable();
            Map(x => x.PlayedCount).Not.Nullable();
            Map(x => x.StoppedCount).Not.Nullable();
            Map(x => x.UnwatchedEpisodeCount).Not.Nullable();
            Map(x => x.WatchedCount).Not.Nullable();
            Map(x => x.WatchedDate);
            Map(x => x.WatchedEpisodeCount).Not.Nullable();
            Map(x => x.PlexContractVersion).Not.Nullable();
            Map(x => x.PlexContractBlob).Nullable().CustomType("BinaryBlob");
            Map(x => x.PlexContractSize).Not.Nullable();
        }
    }
}