﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SaaSOvation.Common.Domain;
using SaaSOvation.Collaboration.Domain.Model.Tenants;
using SaaSOvation.Collaboration.Domain.Model.Collaborators;

namespace SaaSOvation.Collaboration.Domain.Model.Calendars
{
    public class CalendarCreated : IDomainEvent
    {
        public CalendarCreated(Tenant tenant, CalendarId calendarId, string name, string description, Owner owner, IEnumerable<CalendarSharer> sharedWith)
        {
            this.Tenant = tenant;
            this.CalendarId = calendarId;
            this.Name = name;
            this.Description = description;
            this.Owner = owner;
            this.SharedWith = sharedWith;
        }

        public Tenant Tenant { get; private set; }

        public CalendarId CalendarId { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public Owner Owner { get; private set; }

        public IEnumerable<CalendarSharer> SharedWith { get; private set; }

        public int EventVersion { get; set; }
        public DateTime OccurredOn { get; set; }
    }
}
