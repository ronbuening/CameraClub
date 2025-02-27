## Object/Model Description
### Member
This object contains all the member details including name, contact info, club information and role to determine access rights.
#### Member Attributes
- Guid memberId
    - Internal Member ID
    - Required, will serve as PK for member records, set at account creation
- string firstName
    - First name
    - Required, will serve for publicly viewable author and judge records
- string lastName
    - Last name
    - Required, will serve for publicly viewable author and judge records
- string email
    - Member email
    - Required, needed for club records and contact/confirmation
- string password
    - Hashed password string
    - Required, will be hashed separately at account creation
- int? role
    - Integer role identifier
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

##### Related DTO
- CMember
    - Full member creation (all required and optional fields)
- CQMember
    - Quick member creation (only required fields)

### Photo
This object defines an uploaded photograph and specific attributes
#### Photo Attributes
- Guid photoId
    - Internal Photo ID
    - Required, will serve as PK for photo records, assigned at object creation
- string filename
    - Photo filename
    - Required, where the image is stored
- Guid ownerId
    - Internal Member ID for authorship
    - Required, FK for relation to member records, Guid for uploading member
- string author
    - First and last name of author
    - Required, display name for galleries and competitions. Derived from ownerId record
- string title
    - Photo title
    - Required, defined at upload
- string? caption
    - Photo caption
    - Optional, provides additional context for image
- DateOnly? captureDate
    - Date of image caption
    - Optional
- TimeOnly? captureTime
    - Local time of image capture
    - Optional
- string? shutterSpeed
    - Shutter speed used in photo
    - Optional
- string? aperture
    - Aperture for photo
    - Optional
- int? ISO
    - ISO used for photo
    - Optional
- double? exposureBias
    - Exposure Compensation
    - Optional
- string? cameraMake
    - Camera make (e.g. Nikon, Ricoh IMAGING COMPANY, LTD.)
    - Optional
- string? cameraModel
    - Camera model (e.g. Z 7_2, GR III)
    - Optional
- string? lensMake
    - Lens make (e.g. NIKKOR, Canon)
    - Optional
- string? lensModel
    - Lens model (e.g. Z 24-70mm f/2.8 S)
    - Optional
- bool isColor
    - Marker for if image is color or not
    - Required, determines if eligible for color or monochrome categories
- bool isTheme
    - Marker for if the image is part of competition special theme or not
    - Required, determines if eligible for special rules
##### Related DTO
- UPhoto (required fields only)(not implemented)

### Competition
The Competition object defines the different competitions that take place and the various start and end dates
#### Competition Attributes
- Guid competitionId
    - Internal identifier for each competition
    - Required, PK for competition records, assigned at object creation
- string name
    - Competition name
    - Required, name displayed in competition records, defined at object creation
- string description
    - Competition description
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