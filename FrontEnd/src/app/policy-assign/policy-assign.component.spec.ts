import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PolicyAssignComponent } from './policy-assign.component';

describe('PolicyAssignComponent', () => {
  let component: PolicyAssignComponent;
  let fixture: ComponentFixture<PolicyAssignComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PolicyAssignComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PolicyAssignComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
