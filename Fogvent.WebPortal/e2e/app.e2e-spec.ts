import { WebPortalPage } from './app.po';

describe('web-portal App', () => {
  let page: WebPortalPage;

  beforeEach(() => {
    page = new WebPortalPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!');
  });
});
