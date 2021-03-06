﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SacramentMeetingPlanner_Sunday.Models;

namespace SacramentMeetingPlanner_Sunday.Data
{
    public class DbInitializer
    {
        public static void Initialize(SacramentMeetingPlanner_SundayContext context)
        {
            if (context.MeetingPlanner.Any())
            {
                return;
            }

            var planArrays = new MeetingPlanner[]
            {
                new MeetingPlanner
                {
                    MeetingDate = DateTime.Parse("2020-12-20"),
                    ConductingLeader = "Brother Matthew Bachelor",
                    OpeningHymnNumber = 26,
                    OpeningHymnTitle = "Oh! How Lovely was the Morning",
                    OpeningPrayer = "Mary Coker",
                    SacramentHymnNumber = 196,
                    SacramentHymnTitle = "Jesus Once of Humble Birth",
                    IntermediateHymnNumber = 70,
                    IntermediateHymnTitle = "Sing Praise to Him",
                    ClosingHymnNumber = 166,
                    ClosingHymnTitle = "Abide with Me",
                    ClosingPrayer = "Martin Oakley"
                },

                new MeetingPlanner
                {
                    MeetingDate = DateTime.Parse("2020-12-27"),
                    ConductingLeader = "Bishop Samuel Ammon",
                    OpeningHymnNumber = 201,
                    OpeningHymnTitle = "Joy to the World",
                    OpeningPrayer = "Michael Anthony",
                    SacramentHymnNumber = 193,
                    SacramentHymnTitle = "I Stand All Amaze",
                    IntermediateHymnNumber = 202,
                    IntermediateHymnTitle = "Oh, Come all ye Faithful",
                    ClosingHymnNumber = 204,
                    ClosingHymnTitle = "Silent Night",
                    ClosingPrayer = "Angela Morrison"
                }
            };

            foreach(MeetingPlanner planner in planArrays)
            {
                context.MeetingPlanner.Add(planner);
            }
            context.SaveChanges();

            var speakerArrays = new MeetingSpeaker[]
            {
                new MeetingSpeaker
                {
                    MeetingPlannerID = planArrays.Single(c => c.MeetingDate == DateTime.Parse("2020-12-20")).MeetingPlannerID,
                    MeetingSpeakerName = "Akins Smith",
                    MeetingSpeakerTopic = "Joseph Smith: The Prophet of the Restoration"
                },

                new MeetingSpeaker
                {
                     MeetingPlannerID = planArrays.Single(c => c.MeetingDate == DateTime.Parse("2020-12-20")).MeetingPlannerID,
                    MeetingSpeakerName = "Jayden Sabbath",
                    MeetingSpeakerTopic = "The Living Prophets Today"
                },

                new MeetingSpeaker
                {
                     MeetingPlannerID = planArrays.Single(c => c.MeetingDate == DateTime.Parse("2020-12-20")).MeetingPlannerID,
                    MeetingSpeakerName = "Maxwell Allstar",
                    MeetingSpeakerTopic = "We Listen to a Prophet Voice"
                },

                new MeetingSpeaker
                {
                    MeetingPlannerID = planArrays.Single(c => c.MeetingDate == DateTime.Parse("2020-12-27")).MeetingPlannerID,
                    MeetingSpeakerName = "Jeremiah Ussher",
                    MeetingSpeakerTopic = "The Birth of Jesus Christ"
                },

                new MeetingSpeaker
                {
                     MeetingPlannerID = planArrays.Single(c => c.MeetingDate == DateTime.Parse("2020-12-27")).MeetingPlannerID,
                    MeetingSpeakerName = "Dora Cobblah",
                    MeetingSpeakerTopic = "The Life of Jesus Christ"
                },

                new MeetingSpeaker
                {
                     MeetingPlannerID = planArrays.Single(c => c.MeetingDate == DateTime.Parse("2020-12-27")).MeetingPlannerID,
                    MeetingSpeakerName = "Alexander Aikins",
                    MeetingSpeakerTopic = "The Atonement of Jesus Christ"
                }
            };

            foreach(MeetingSpeaker speaker in speakerArrays)
            {
                context.MeetingSpeaker.Add(speaker);
            }
            context.SaveChanges();
        }
    }
}
