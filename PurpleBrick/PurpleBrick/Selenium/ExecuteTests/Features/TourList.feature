Feature: TourListStep
Create Tour List and delete it while the system set on USA configuratiion	

Scenario Outline: Create Tour List and delete it
Given I navigate to purplebricks home page on a system with configuration '<configuration>'
When I click on the no thank button
Given I click Tour list button on marketing site
And I see and type into empty text field to add a name for my Tour list '<tourListName>'
And I click Create Tour List button
And the new tour list should be created
And I delete the created tourList
Then the tourList should be deleted

Examples: 
| tourListName         |configuration                              |
| Purple Bricks        | https://pbuser:Lmeiub501!@qa-us.pbr.so/]  |