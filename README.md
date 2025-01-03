# HotelApp

## Requirements

### W, O

Technical:
- Both user and admin parts will be part of the same web apps
- ASP.NET Core Blazor Web App
- SQL-like data layer

Assumptions:
- This is single hotel app
- Book a room type, not specific room number

From user:
- Book a room:
    - See what is currently available
    - See room category (1B, 2B, rooms)
    - See room description
    - See room prices per night
    - Select start date
    - Select end date
    - See total price
- Manage current reservations:
    - Be able to login and see list of current, previous reservations (start date, end date, etc...)
    - Be able to cancel current reservation
- Ability to self-check-in when in the hotel:
    - A simple lookup via last name or phone number or email address
    - Ability to click check-in

From admin:
- Ability to see all rooms list
    - Status of each room
    - Room number
- Ability to find a reservation for a user by last name or phone number or email address
