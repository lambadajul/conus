# Architecture

```
             Program
                │
                ▼
         TagRepository
                │
                ▼
         SearchService
        ┌───────┼────────┐
        ▼       ▼        ▼
   Filter   Statistics   CSV Export
                │
                ▼
          ConsoleTable
```

## Components

### TagRepository

Provides access to PLC tags.

### SearchService

Searches tags by keyword.

### FilterService

Filters tags by type and group.

### CsvExportService

Exports tag lists to CSV.

### StatisticsService

Calculates summary information.
