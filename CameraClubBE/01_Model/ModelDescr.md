## Object/Model Description
### Member
This object contains all the member details including name, contact info, club information and role to determine access rights.
#### Member Attributes
- Guid memberId
    - Required, will serve as PK for member records, set at account creation
- string firstName
    - Required, will serve for publicly viewable author and judge records
- string lastName
    - Required, will serve for publicly viewable author and judge records
- string email
    - Required, needed for club records and contact/confirmation
- string password
    - Required, will be hashed separately at account creation
- int? role
    - Optional, will default to least permissive
    - Permissions will go from 0 to 4 inclusive with most permissions given with lower number
        - 0: System Admin
            - Full rights
        - 1: Club Admin
            - Can create new members, assign roles, act as judge, and view all uploaded photos for moderation purposes
        - 2: Club Judge
            - Can leave ratings and comments on images entered to competitions for which they are assigned as judge and act as regular club members
            - Disallowed from leaving ratings and comments on their own photos in competition
        - 3: Club Member
            - Can upload photos, enter competitions, and review all results
        - 4: Club Viewer
            - Can view closed competitions and results
- DateOnly? dateJoined
    - Date first active in club
- string? phone
- string? addressLine1
- string? addressLine2
- string? city
- string? state
- string? postalCode
- string? country
- DateOnly? dateBirth
    - Only if really desired by club mgmt
##### Related DTO
- CMember
    - Full member creation (all required and optional fields)
- CQMember
    - Quick member creation (only required fields)

### Photo
This object defines an uploaded photograph and specific attributes
#### Photo Attributes
- Guid photoId
    - Required, will serve as PK for photo records, assigned at object creation
- string filename
    - Required, where the image is stored
- Guid ownerId
    - Required, FK for relation to member records, Guid for uploading member
- string author
    - Required, display name for galleries and competitions. Derived from ownerId record
- string title
    - Required, defined at upload
- string? caption
    - Optional, provides additional context for image
- DateOnly? captureDate
- TimeOnly? captureTime
- string? shutterSpeed
- string? aperture
- int? ISO
- double? exposureBias
- string? cameraMake
- string? cameraModel
- string? lensMake
- string? lensModel
- bool isColor
    - Required, determines if eligible for color or monochrome categories
##### Related DTO
- UPhoto (required fields only)(not implemented)

### Competition
The Competition object defines the different competitions that take place and the various start and end dates
#### Competition Attributes
- Guid competitionId
    - Required, PK for competition records, assigned at object creation
- string name
    - Required, name displayed in competition records, defined at object creation
- string description
    - Required, description for specific competition, defined at object creation
- DateTime startEntryDate
    - Required, start date for adding or updating entries
- DateTime endEntryDate
    - Required, end date for adding or updating entries
- DateTime startJudgeDate
    - Required, start date for adding or updating ratings and comments
- DateTime endJudgeDate
    - Required, end date for adding or updating ratings and comments
- string tag
    - Required, used for short-hand reference
- List<Photo> entries
    - Optional, created as photos are added
- List<Member> judges
    - Required, will be used to define who can rate entries
##### Related DTO