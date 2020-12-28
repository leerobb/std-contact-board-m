namespace STD_Contact_Board.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedJurisdiction : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[Jurisdictions] ON");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (1, N'Alabama
', N'Alabama Department of Public Health
', N'201 Monroe Street, The RSA Tower, Montgomery, AL 36104
', N'(334) 206-2765
', N'(334) 206-2768
')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (2,N'Alaska',N'Alaska Department of Health and Social Services',N'Alaska Department of Health and Social Services Section of Epidemiology HIV / STD Program 3601 C Street, Suite 540 Anchorage, AK 99503',N'(907) 269 - 8000',N'(907) 561 - 4239')");
Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (3,N'Arizona',N'Arizona Department of Health Services',N'Office of Disease Integration & Services
150 N. 18th Avenue, Suite 110
Phoenix, AZ 85007',N'(602) 542 - 1025',N'(602) 542 - 0883')");
Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (4,N'Arkansas',N'Arkansas Department of Health',N'4815 W. Markham St., Slot 33 Little  Rock AR 72205',N'501-661-2408',N'501-661-2082')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(5, N'Baltimore', N'Baltimore City Health Department', N'Baltimore City Department of Health,  Bureau of HIV/STD Services  1001 East Fayette Street Baltimore, MD 21202', N'410-396-4448', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (6,N'California',N'California Department of Health',N'California Department of Public Health, Office of AIDS MS 7700 P.O. Box 997426 Sacramento, CA 95899-7426',N'916-558-1784',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(7, N'Chicago', N'Chicago Department of Public Health', N'City of Chicago Dept. of Health 333 S. State Street
            Room 200
            Chicago, IL 60604',N'312.747.9884',N'N / A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (8,N'Colorado',N'Colorado Department of Public Health and Environment',N'Colorado Department of Public Health and Environment DCEED-STI/HIV-A3 4300 Cherry Creek, South                                                                                                 DenverCO 80246',N'303-692-2700',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(9, N'Connecticut', N'Connecticut Department of Public Health', N'The Connecticut Department of Public Health, STD Control Program 410 Capitol Avenue, MS# 11STD, Hartford, CT 06134', N'(860) 509-7920', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (10,N'Delaware',N'Delaware Division- Public Health',N'540 S Dupont Hwy #4, Dover, DE 19901',N'(302) 744-4700',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(11, N'District of Columbia', N'District of Columbia Health', N'899 North Capitol Street, NE, Washington, DC 20002', N'(202) 442-5955', N'(202) 442-4795')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (12,N'Florida',N'Florida Department of Health',N'HIV/AIDS Section 4052 Bald Cypruss Way Tallahasse, FL 32399',N'850-245-4422',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(13, N'Georgia', N'Georgia Department of Public Health', N'Georgia Department of Health, Epi Section PO Box 2107 Atlanta, GA 30341', N'1-800-827-9769', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (14,N'Hawaii',N'Hawaii State Department of Health',N'3627 Kilauea Ave. Honolulu, HI 96816',N' HIV (808) 733-4079 and STD (808) 733-9281',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(15, N'Idaho', N'Idaho Department of Health and Welfare', N'1720 N Westgate Dr, Boise, ID 83704', N'208-334-6700', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (16,N'Illinois',N'Illinois Department of Public Health',N'122 S. Michigan Avenue, 7th and 20th Floors, Chicago Il 60603',N'312-814-2793',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(17, N'Indiana', N'Indiana State Department of Health', N'2 N Meridian St, Indianapolis, IN 46204', N'(317) 233-1325', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (18,N'Iowa',N'Iowa Department of Public Health',N'321 E 12th St 6th floor, Des Moines, IA 50319',N' (515) 281-7689',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(19, N'Kansas', N'Kansas Department of Health and Environment', N'1000 SW Jackson, Suite 540
            Topeka, Kansas 66612 - 0461',N'(785) 296 - 1086',N'N / A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (20,N'Kentucky',N'Kentucky Departmetn for Public Health',N'HIV/AIDS Branch (DPH)275 E. Main St. HS2E-C Frankfort, KY 40621',N'(502) 564-6539',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(21, N'Louisiana', N'Louisiana Department of Health', N'PO Box 629 Baton Rouge, LA 70821-0629', N'(225) 342-9500', N'(225) 342-5568')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (22,N'Los Angeles',N'Los Angeles County Department of Health Services',N'Division of HIV and STD Programs 600 S. Commonwealth Ave., 10th Floor Los Angeles, CA 90005',N'(213) 351-8000',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(23, N'Maine', N'Maine Department of Health and Human Services', N'109 Capitol St 11 State House Station Augusta, ME 04330', N'(207) 287-3707', N'(207) 287-3005')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (24,N'Maryland',N'Maryland Department of Health',N'201 W. Preston Street, Baltimore, MD 21201-2399',N'(410) 767-6500 or 1-877-463-3464',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(25, N'Massachusetts', N'Massachusetts Department of Public Health', N'250 Washington Street, Boston MA 02018', N'(617) 624-6000', N'(617) 624-5206')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (26,N'Michigan',N'Michigan Department of Health and Human Services',N'333 S. Grand Ave P.O. Box 30195 Lansing, Michigan 48909',N'517-241-3740',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(27, N'Minnesota', N'Minnesota Department of Health', N'P.O. Box 64975 St. Paul, MN 55164-0975', N'651-201-5000', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (28,N'Mississippi',N'Mississippi State Department of Health',N'Post Office Box 1700 Jackson , MS 39215-1700',N'601-576-7400',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(29, N'Missouri', N'Missouri Department of Health and Senior Services', N'Bureau of HIV, STD, and Hepatitis PO Box 570 Jefferson City, MO 65102', N'573-751-6439', N'573-751-6447')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (30,N'Montana',N'Montana Department of Public Health and Human Serivces Division',N'Cogswell Building
Room C-211
1400 Broadway
Helena, MT 59620',N'(406) 444 - 3565',N'N / A')");
Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (31,N'Nebraska',N'Nebraska Department of Public Health and Human Serivce Division',N'301 Centennial Mall South, Lincoln,  Nebraska 68509 ',N'(402) 471-3121',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(32, N'Nevada', N'Nevada Department of Health and Human Services', N'4126 Technology Way # 100, Carson City, NV 89706', N'(775) 684-4000', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (33,N'New Hampshire',N'New Hampshire Department of Health and Human Serivces',N'129 Pleasant Street Concord, NH 03301-3852',N'(603) 271-9700',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(34, N'New Jersey', N'New Jersey State Health Department', N'P. O. Box 360 Trenton, NJ 08625-0360', N'(800) 367-6543', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (35,N'New Mexico',N'New Mexico Department of Health',N'7704 2nd St NW, Albuquerque, NM 87107',N'(505) 222-0361',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(36, N'NY City', N'New York City Department of Health & Mental Hygiene', N'600 W 168th St, New York, NY 10032', N'(212) 368-4500', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (37,N'NY State',N'New York State Department of Health',N' Empire plaza, Corning Tower, State St, Albany, NY 12203',N'N/A',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(38, N'N. Carolina', N'North Carolina Department of Health and Human Services', N'1931 Mail Service Center Raleigh, NC 27699 - 1931', N'919-707-5000', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (39,N'N. Dakota',N'North Dakota Department of Health',N'Division of Disease Control 2635 East Main Ave PO Box 5520 Bismark, ND 58506-5520',N'800.472.2180',N'701.328.2499')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(40, N'Ohio', N'Ohio Department of Health', N'246 N High St, Columbus, OH 43215', N'614) 466-3543', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (41,N'Oklahoma',N'Oklahoma State Department of Health',N'1000 NE 10th St, Oklahoma City, OK 73104',N' (405) 271-5600',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(42, N'Oregon', N'Oregon Health Authority-Public Health Division', N'800 NE Oregon St, Portland, OR 97232', N'(971) 673-1222', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (43,N'Pennsylvania',N'Pennsylvania Department of Health',N'Health and Welfare Building 8th Floor West 625 Forster Street Harrisburg, PA 17120',N'N/A',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(44, N'Philadelphia', N'Philidelphia Department of Public Health', N'1101 Market St. 13th Floor Philadelphia, PA 19107', N'215-686-5200', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (45,N'Puerto Rico',N'Puerto Rico Department of Health',N'Norte Medical Center Calle Periferial Interior Bo. Monacillos Rio Piedras, PR',N'787-765-2929',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(46, N'Rhode Island', N'Rhode Island Department of Health', N'3 Capitol Hill Providence RI, 02908', N'401-222-5960', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (47,N'San Francisco',N'San Francisco Department of Public Health',N'2789 25th St, San Francisco, CA 94110',N'N/A',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(48, N'S. Carolina', N'South Carolina DHEC', N'2100 Bull Street, Coulmbia , SC 29201', N'(803) 898-3432', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (49,N'S. Dakota',N'South Dakota Department of Heath',N'Robert Hayes Bldg. 600 E. Capitol Ave. Pierre, SD 57501-2536',N'605-773-3361',N'605-773-5683')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(50, N'Tennessee', N'Tennessee Department of Health', N'710 James Robertson Parkway, Nashville, TN 37243', N'(615)741-7500', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (51,N'Texas',N'Texas Department of State Health Services',N'PO Box 149347 Austin, Texas 78714-9347',N'512-776-7111',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(52, N'Utah', N'Utah Department of Human Services', N'195 N 1950 W, Salt Lake City, UT 84116', N'(801) 538-4171', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (53,N'Vermont',N'Vermont Department of Health',N'108 Cherry Street Burlington, VT 05402',N'800-464-4343',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(54, N'US Virgin Islands', N'USVI Department of Health', N'Charles Harwood Complex 3500 Estate Richmond  Christiansted, VI 00820', N'340-718-1311', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (55,N'Virginia',N'Virginia Department of Health',N'P.O Box 2448 Richmond, VA 23218-2448',N'(804) 864-7000',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(56, N'Washington', N'Washington State Department of Health', N'111 Israel Rd SE, Tumwater, WA 98501', N'(800) 525-0127', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (57,N'West Virginia',N'West Virginia Department of Health',N'One Davis Square, Suite 100 East Charleston, West Virginia 25301',N'(304) 558-0684',N'(304) 558-1130')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(58, N'Wisconsin', N'Wisconsin Department of Health Services', N'Department of Health Services 1 West Wilson Street Madison, WI 53703', N'608-266-1865', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (59,N'Wyoming',N'Wyoming Department of Health',N'401 Hathaway Building Cheyenne, WY 82002',N'1-866-571-0944 ',N'(307) 777-7439')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(60, N'American Samoa', N'Ministry of Health', N'563P+RP Apia, Samoa inquiries@health.gov.ws', N' + 685-6811', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (61,N'Commonwealth of Northern Mariana Islands (CNMI)',N'',N'P.O Box 500409 Saipan, MP 96950',N'N/A',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(62, N'Federated States of Micronesia (FSM)', N'', N'PS70 Palikar FSM 96941', N'691-320-2872', N'N/A')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (63,N'Guam',N'Guam Department of Health',N'Department of Public Health and Social Services
 123 Chalan Kareta, Mangilao, Guam 96913 - 6304

',N'671 - 735 - 7166',N'N / A')");
Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (64,N'Republic of Marshall Islands (RMI)',N'Minister of Health',N'P.O Box 16 Majuro, MH 96960',N'692-625-5660',N'N/A')");
Sql(@"INSERT INTO[dbo].[Jurisdictions]([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES(65, N'Republic of Palau', N'Ministry of Finance', N'P.O Box 6011 Ngerulmud, Palau 96940', N'680-488-2552', N'680-488-0000')");
            Sql(@"INSERT INTO [dbo].[Jurisdictions] ([Id], [JurisdictionName], [AgencyName], [MainAddress], [Phone], [Fax]) VALUES (66,N'National Coalition of STD Directors',N'',N'1029 Vermont Ave., NW, Suite 500 Washington, DC 20005',N'202-842-4660',N'202-842-4542')");

            Sql(@"SET IDENTITY_INSERT [dbo].[Jurisdictions] OFF");

        }
        
        public override void Down()
        {
        }
    }
}
