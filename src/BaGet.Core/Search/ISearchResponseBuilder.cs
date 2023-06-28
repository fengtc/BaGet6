﻿using BaGet.Protocol.Models;
using System.Collections.Generic;

namespace BaGet.Core;

public interface ISearchResponseBuilder
{
    SearchResponse BuildSearch(IReadOnlyList<PackageRegistration> results);
    AutocompleteResponse BuildAutocomplete(IReadOnlyList<string> data);
    DependentsResponse BuildDependents(IReadOnlyList<PackageDependent> results);
}
