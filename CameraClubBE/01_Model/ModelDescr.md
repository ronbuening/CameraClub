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
        - 1: Club Admin
        - 2: Club Judge
        - 3: Club Member
        - 4: Club Viewer
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

### Photo
This object defines an uploaded photograph and specific attributes
#### Photo Attributes
- Guid photoId
    - Required, assigned at object creation
- string filename
    - Required, where the image is stored
- Guid ownerId
    - Required, Guid for uploading member
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