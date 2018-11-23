using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem.com.bugtracking.controller
{
    class GitController
    {
        private readonly string _repoSource;
        private readonly UsernamePasswordCredentials _credentials;
        private readonly DirectoryInfo _localFolder;
        private string localfolder;

        /// <summary>
        /// Initializes a new instance of the <see cref="GitRepositoryManager" /> class.
        /// </summary>
        /// <param name="username">The Git credentials username.</param>
        /// <param name="password">The Git credentials password.</param>
        /// <param name="gitRepoUrl">The Git repo URL.</param>
        /// <param name="localFolder">The full path to local folder.</param>

        public GitController(string username, string password, string gitRepoUrl, string localFolder) {

            this.localfolder = localFolder;
            var folder = new DirectoryInfo(localFolder);

            if (!folder.Exists)
            {
                throw new Exception(string.Format("Source folder '{0}' does not exist.", _localFolder));
            }

            _localFolder = folder;

            _credentials = new UsernamePasswordCredentials
            {
                Username = username,
                Password = password
            };
            
        

        _repoSource = gitRepoUrl;
            
            Console.WriteLine("Connected to Local Repository");
            Console.WriteLine("Connected to Github Repository :"+_repoSource);
            Console.WriteLine("");

        }
       
        //method to commit messages to repository
        public void Commit(String message)
        {
            using (var repo = new Repository(localfolder))
            {
                // Write content to file system
                var content = message;
                File.WriteAllText(Path.Combine(repo.Info.WorkingDirectory, "fileToCommit.txt"), content);

                // Stage the file
                repo.Stage("fileToCommit.txt");

                // Create the committer's signature and commit
                Signature author = new Signature("Xawbeenregmi", "@xawbeenregmi", DateTime.Now);
                Signature committer = author;

                // Commit to the repository
                Commit commit = repo.Commit(message);

                MessageBox.Show("Committed");
            }
        }

        //method to get Commit History
        public void getCommitHistory()
        {
          

            using (var repo = new Repository(localfolder))
            {
                var RFC2822Format = "ddd dd MMM HH:mm:ss yyyy K";

                foreach (Commit c in repo.Commits.Take(15))
                {
                    Console.WriteLine(string.Format("commit {0}", c.Id));

                    if (c.Parents.Count() > 1)
                    {
                        
                        Console.WriteLine("Merge: {0}",
                            string.Join(" ", c.Parents.Select(p => p.Id.Sha.Substring(0, 7)).ToArray()));
                    }

                    Console.WriteLine(string.Format("Author: {0} <{1}>", c.Author.Name, c.Author.Email));
                    Console.WriteLine("Date:   {0}", c.Author.When.ToString(RFC2822Format, CultureInfo.InvariantCulture));
                    Console.WriteLine();
                    Console.WriteLine(c.Message);
                    Console.WriteLine();
                }
            }
        }
       
        /// <summary>
        /// Pushes all commits.
        /// </summary>
        /// <param name="remoteName">Name of the remote server.</param>
        /// <param name="branchName">Name of the remote branch.</param>
        /// <exception cref="System.Exception"></exception>
        

        // method to push commits to github repo
        public void PushCommits()
        {

            using (var repo = new Repository(localfolder))
            {
                Remote remote = repo.Network.Remotes["origin"];
                var options = new PushOptions();
                options.CredentialsProvider = (_url, _user, _cred) =>
                    new UsernamePasswordCredentials { Username = "xawbeenregmi", Password = "n0b0dycanhackme" };
                repo.Network.Push(remote, @"refs/heads/master", options);
                Console.WriteLine("Pushed to github");
                MessageBox.Show("Pushed to github");
            }
        }


    }

  

}
