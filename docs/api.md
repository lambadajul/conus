# Internal API

## TagRepository

### GetAll()

Returns all PLC tags.

### FindByName(name)

Returns a tag by its name.

## SearchService

### Find(tags, keyword)

Searches tags using a keyword.

## FilterService

### ByType(tags, type)

Filters tags by data type.

### ByGroup(tags, group)

Filters tags by group.

## CsvExportService

### Export(tags)

Returns CSV-formatted text.
